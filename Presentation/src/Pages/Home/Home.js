import React, {Component} from 'react'
import axios from 'axios'
import SearchBox from '../Search/SearchBox';    
import './home.css';
import Card from '../Card/Card';

class Home extends Component{

    constructor(){
        super();
        this.state = {
            zipCodes: [],
            selected:null,
            card:''
        }
    }

    selectedCode = (opt)=>{
        this.setState({
            selected: (opt.length == 0 ? [] : opt[0]),
            card: <Card selected={(opt.length == 0 ? [] : opt[0])}/>
        })
        
    }

    render(){
        
        if(this.state.zipCodes.length === 0) return (<div><p> Loading ...</p></div>);

        return (
                <div className="home">
                    <div className="upper-fold">
                        <div className="col col-lg-6 offset-lg-3 col-md-6 offset-md-3 col-sm-10 offset-sm-1 col-10 offset-1 ">
                            <div>
                            <div className="card principal">
                                <div className="card-body">
                                    <div className="col-12">
                                        <blockquote className="blockquote mb-0">
                                            <p><i className="fas fa-map-pin"></i> Places in Nicaragua</p>                                       
                                        </blockquote>
                                    </div>
                                    <div className="col-12">
                                        <SearchBox zipCodes={this.state.zipCodes} selectedCode={this.selectedCode}/>  
                                    </div>
                                </div>
                            </div>
                            </div>
                        </div>
                    </div>
                    <div className="row">
                        <div className="row ">
                            <h5>Results:</h5>
                        </div>
                        <div className="row">
                            <div className="col-12 col-md-4 col-lg-4">
                                {this.state.card}
                            </div>
                        </div>
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
