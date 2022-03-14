
import './pricingtool.css';
import ProposalData from './proposal-data';

const PricingTool = () => {
    return(
        
        <div className='w-100'>
            <Header/>
            <ProposalData />                                       
        </div>        
    )
}

const Header = () => {
    return (
        <div className='container-full App-header'>
            <div className='row'>            
                <div className='col'></div>
                <div className='col'>
                    <span className='pt-4'>Institutional Pricing Tool <small>5.6.1</small></span>                
                </div>
                <div className='col text-right'>
                    <small className='text-right'>User123</small>
                </div>
            </div>
        </div>        
    )
}

export default PricingTool;