import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './Bowler/BowlerList';

// Function component for the main application
function App() {
  return (
    <div className="App">
      <Header title="The Strike Zone" />
      <br />
      <BowlerList />
    </div>
  );
}

export default App;
