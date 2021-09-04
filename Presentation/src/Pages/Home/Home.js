import React, {Component} from 'react'
import axios from 'axios'
import SearchBox from '../Search/SearchBox';    
import './home.css';
class Home extends Component{

    constructor(){
        super();
        this.state = {
            zipCodes: []
        }
    }

    render(){
        
        if(this.state.zipCodes.length === 0) return (<div><p> waiting ..</p></div>);

        return (
            <div className="">
                <div className="container-fluid">
                    <div className="row">
                        <div className="home col s12">
                            <div className="upper-fold">
                                <SearchBox zipCodes={this.state.zipCodes}/>        
                            </div>
                        </div>                    
                    </div>
                </div>
                <div className="container-fluid lower-fold">
                    
                </div>
            </div>
        )
    }

      async componentDidMount(){
        const postalCodeUrl = `${window.apiHost}/PostalCode/getCodigos`;
        const axiosResponse = await axios.get(postalCodeUrl);
        this.setState({
            zipCodes: axiosResponse.data
        });
    }    
}

export default Home;
