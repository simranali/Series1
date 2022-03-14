import React,{useState, useEffect} from "react";
import FacilityData from "./facility-data";
import Proposal from "../interfaces/proposal"
import moment from "moment";


const ProposalData = () => {
    const proposals:Array<Proposal> = [];
    const [data, setData] = useState(proposals);
    const [viewProposlDetail,setviewProposlDetail] = useState('');
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState(null);
    
   
    const getData = () =>{
        setLoading(true);
        setError(null);
        fetch(`http://localhost:5000/api/Proposals`)
        .then((response) => response.json())
        .then(setData)
        .catch(setError)
        .finally(()=>setLoading(false));
    }    
    
    return (
        <>
        <div>
            <div className='row'>
                <div className='col m-1'>
                    <button type='button' className='btn btn-lightBlue' onClick={getData}>Get Data</button>
                </div>
                <div className="col-10 m-1">
                    {loading && <b className="text-info">Loading ...</b>}
                    {error && <pre className="text-danger">{JSON.stringify(error, null, 2)}</pre>}
                </div>                
            </div>
            {data.length > 0 &&            
                <div className='row proposal-data-header-row p-2'>
                    <div className='col'>Proposal Name</div>
                    <div className='col'>Customer Group</div>
                    <div className='col'>Date (last saved)</div>
                    <div className='col'>Description</div>
                    <div className='col'>Status</div>
                    <div className='col'>&nbsp;</div>
                </div>
            }
            
        </div>
        {data.map((p) => (
            <div className='container-full border-bottom' key={p.id}>
                <div className='row p-2'>
                    <div className='col'>{p.proposalName}</div>
                    <div className='col'>{p.customerGrpName}</div>
                    <div className='col'>{moment(p.date).format("D MMM YYYY")}</div>
                    <div className='col'>{p.description}</div>
                    <div className='col'>In Preparation</div>                    
                    <div className='col'><button type="button" className="btn facility-data-header p-0" onClick={() => setviewProposlDetail((viewProposlDetail) => p.proposalName)}>VIEW SUMMARY</button></div>
                </div>
                {(viewProposlDetail == p.proposalName) && <FacilityData proposalName={p.proposalName}/>}                
            </div>
        ))}        
        </>        
    )
}

export default ProposalData;