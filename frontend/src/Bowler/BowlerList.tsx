import { useEffect, useState } from 'react';
import { Bowler } from '../Bowler/types/Bowlers';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5032/bowler');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  const filteredBowlerData = bowlerData.filter(
    (f) => f.teamName === 'Marlins' || f.teamName === 'Sharks',
  );

  return (
    <>
      <div className="row">
        <h4 className="text-center">Marlins and Sharks Bowlers</h4>
      </div>
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
