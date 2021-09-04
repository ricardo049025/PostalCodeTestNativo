import React, {Component} from 'react'
import './search.css';
class SearchBox extends Component{
    
    constructor(){
        super();
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
                                                    <div className="input-field" id="where">
                                                    <div>
                                                        <input type="text" id="autocomplete-input browser-default" className="autocomplete" />                                                        
                                                    </div>

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

    componentDidMount()
    {
        var element = document.getElementsByClassName('autocomplete');
        var instance = window.M.Autocomplete.init(element,{"apple":"https://placehold.it/250x250"});        
    }
}

export default SearchBox;

