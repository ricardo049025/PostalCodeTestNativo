import React, {Component} from 'react'
import './search.css';
import {Typeahead} from 'react-bootstrap-typeahead'
class SearchBox extends Component{
    
    constructor(){
        super();
        // this.state={
        //     selected:[]
        // }
    }

    render(){

        return(
            
            <form>
                <div className="row">
                    <div className="col-lg-10 col-md-9 search-box-form">                       
                        <div>
                            <Typeahead 
                            id="basic-typeahead-single"                            
                            onChange={(option) => {this.props.selectedCode(option)}}                            
                            options={this.props.zipCodes} 
                            selected={this.props.selected}
                            key="id"
                            labelKey="zipCodeDescription"
                            placeholder="Select a zip code"
                            />   

                        </div>
                    </div>
                    <div className="col-lg-2 col-md-2 search-box-form">
                        <div className="input-field" id="submit-btn">
                            <button type="button" className="btn btn-success"> <strong>Search</strong></button>
                        </div>
                    </div>
                </div>
            </form>

        )}

  
}

export default SearchBox;

