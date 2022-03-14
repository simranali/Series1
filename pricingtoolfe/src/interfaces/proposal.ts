import React from 'react'

interface Proposal{
    id: number;
    proposalName: string;
    customerGrpName: string;
    date: Date;
    description: string;
    status: string;
}

export default Proposal;