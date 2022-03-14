import moment from "moment";
import React,{useState, useEffect, useReducer} from "react";
import NumberFormat from "react-number-format";
import Facility from "../interfaces/facility";

const FacilityData = (props:any) => {
    const facilities:Array<Facility> = [];    
    const [data, setData] = useState(facilities);
    const [selectedFacility, setFacility] = useState('');
    useEffect(() => {
        fetch(`http://localhost:5000/api/Facilities/${props.proposalName}`).then((response) => response.json())
        .then(setData);
    },facilities);
    
    return (
        <>
            {data.length > 0 ?
            <>
                <div className="container border-top">
                    <div className='form-group row'>     
                        <div className="col-sm-2">
                            <label htmlFor="facilitySelect">Facility</label>
                        </div>               
                        <div className="col-sm-10 p-1">
                            <select className="form-control" id="facilitySelect" onChange={(e) => setFacility((selectedFacility) => e.target.value) }>
                                {data.map((f,i) => (<option key={f.id} value={f.facilityName}>{f.facilityName}</option>))}                            
                            </select>                          
                        </div>                
                    </div>
                    
                    {data.map((f,i) => (
                        <>
                            {((selectedFacility == f.facilityName) || (i==0 && selectedFacility == "")) && 
                                <>
                                    <div className='row p-2 facility-data-header'>
                                        <div className='col'>Booking Country</div>
                                        <div className='col'>Curency</div>
                                        <div className='col'>Limit ({f.currency})</div>
                                        <div className='col'>Start Date</div>
                                        <div className='col'>Maturity Date</div>
                                    </div>
                                    <div className='row p-2'>
                                        <div className='col'>{f.bookingCountry}</div>
                                        <div className='col'>{f.currency}</div>
                                        <div className='col'><NumberFormat value={f.limit} displayType={'text'} thousandSeparator={true} /></div>
                                        <div className='col'>{moment(f.startDate).format("D MMM YYYY")}</div>
                                        <div className='col'>{moment(f.maturityDate).format("D MMM YYYY")}</div>
                                    </div>
                                </>
                            }
                        </>
                    ))}
                </div>
            </>            
            : <div className="container border-top"><div className='row p-2'><b className="facility-data-header">No facilities found</b></div></div>
            }
        </>
                
    )
}

export default FacilityData;