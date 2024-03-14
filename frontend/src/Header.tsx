import logo from './bowlingLogo.png';

// Header component that takes props for dynamic content
function Header(props: any) {
  return (
    // Main container for the header with styled background to mimic a bowling lane
    <header
      className="row navbar navbar-dark"
      style={{
        padding: '10px 20px',
        display: 'flex',
        alignItems: 'center',
        background: 'linear-gradient(180deg, #553311, #aa7744)', // Simulate wood color
        color: 'white',
        borderBottom: '2px solid #fff', // Simulate the polished look of a bowling lane
      }}
    >
      <div className="col-4" style={{ display: 'flex', alignItems: 'center' }}>
        <img
          src={logo}
          className="logo"
          alt="logo"
          style={{
            maxWidth: '100px',
            height: 'auto',
            marginRight: '15px',
          }}
        />
      </div>
      <h1
        className="col subtitle"
        style={{
          color: '#fff', // White text for contrast
          fontSize: '1.5rem', // Responsive font size
          margin: 0,
          fontWeight: 'bold',
          textShadow: '1px 1px 2px #000', // Text shadow for readability
        }}
      >
        {props.title} {/* Dynamically received title prop */}
      </h1>
      {/* Bowling lane arrows*/}
      <div
        style={{
          position: 'absolute',
          bottom: '10px',
          left: '50%',
          transform: 'translateX(-50%)',
          width: '100%',
          height: '20px',
          background:
            'repeating-linear-gradient(45deg, transparent, transparent 10px, #fff 10px, #fff 20px)', // Creates arrow-like pattern
          opacity: 0.5, // Slightly see-through for a subtle effect
        }}
      />
    </header>
  );
}

export default Header;
