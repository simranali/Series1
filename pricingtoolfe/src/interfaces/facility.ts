import React from 'react'
interface Facility{
    id: number;
    proposalName: string;
    facilityName: string;
    bookingCountry: string;
    currency: string;
    startDate?: Date;
    maturityDate?: Date;
    limit: number;
}

export default Facility;