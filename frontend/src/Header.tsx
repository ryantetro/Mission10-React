import logo from './bowlingLogo.png';

function Header(props: any) {
  return (
    <header
      className="row navbar navbar-dark bg-dark"
      style={{ padding: '10px 20px', display: 'flex', alignItems: 'center' }}
    >
      <div className="col-4" style={{ display: 'flex', alignItems: 'center' }}>
        <img
          src={logo}
          className="logo"
          alt="logo"
          style={{ maxWidth: '100px', height: 'auto', marginRight: '15px' }}
        />
      </div>
      <h1
        className="col subtitle"
        style={{
          color: '#ffdd59',
          fontSize: '24px',
          margin: 0,
          fontWeight: 'bold',
        }}
      >
        {props.title}
      </h1>
    </header>
  );
}

export default Header;
