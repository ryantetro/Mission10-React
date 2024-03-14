import { useEffect, useState } from 'react';
import { Bowler } from '../Bowler/types/Bowlers';

function BowlerList() {
  // State to store bowler data fetched from the API
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  // useEffect hook to fetch bowler data from the backend when the component mounts
  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5032/bowler');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  // Filter bowler data for specific teams ('Marlins' or 'Sharks')
  const filteredBowlerData = bowlerData.filter(
    (f) => f.teamName === 'Marlins' || f.teamName === 'Sharks',
  );

  return (
    <>
      {/* Header section for the bowler list */}
      <div className="row">
        <h3 className="text-center">
          Take a look at all of our Amazing Bowlers!
        </h3>
        <br></br>
        <h4 className="text-center">Marlins and Sharks Bowlers</h4>
      </div>
      {/* Table to display filtered bowler data */}
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>First Name</th>
            <th>Middle Initial</th>
            <th>Last Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip Code</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {/* Map through the filtered bowler data to render table rows */}
          {filteredBowlerData.map((b) => (
            <tr key={b.id}>
              <td>{b.firstName}</td>
              <td>{b.middleInitial}</td>
              <td>{b.lastName}</td>
              <td>{b.teamName}</td>
              <td>{b.address}</td>
              <td>{b.city}</td>
              <td>{b.state}</td>
              <td>{b.zip}</td>
              <td>{b.phoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
