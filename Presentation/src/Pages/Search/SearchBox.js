import React, {Component} from 'react'
import './search.css';
import {Typeahead} from 'react-bootstrap-typeahead'
class SearchBox extends Component{
    
    constructor(){
        super();
        this.state={
            selected:null
        }
    }

    render(){

        return(
            
            <div className="container-fluid">
                <div className="row">
                    <div className="home col s12">
                        <div className="upper-fold">
                            <div className="row">
                                <div className="col l4 offset-l4 m4 offset-m4 s12" style={{marginTop: 40}}>
                                    <div className="card-panel white">
                                        <div className="row">
                                            <h5>Places in Nicaragua</h5>
                                            <form className="search-box-form">
                                                <div className="col m12">                       
                                                    <div>
                                                        <Typeahead 
                                                        id="basic-typeahead-single"
                                                        onChange={(option) => {this.setState({selected: option})}}
                                                        selected={this.state.selected}
                                                        options={this.props.zipCodes} 
                                                        key="id"
                                                        labelKey="zipCode"
                                                        placeholder="Select a zip code"
                                                        />   

                                                    </div>
                                                </div>
                                                <div className="col m12 submit-btn center">
                                                    <div className="input-field" id="submit-btn">
                                                        <button className="btn waves-effect waves-light red accent-2"><i className="material-icons">search</i> <strong>Search</strong></button>
                                                    </div>
                                                </div>
                                            </form>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        )}

  
}

export default SearchBox;

