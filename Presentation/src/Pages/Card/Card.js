import React,{Component} from 'react'

class Card extends Component{

    render(){
        
        if(this.props.selected.length == 0) return (<div></div>);

        const {departament,municipality,zipCodeDescription,zipCode,neighborhood} = this.props.selected;        
        return (
            <div className="card"  >
                <img src="https://media.gettyimages.com/vectors/map-location-icon-flat-vector-id1143824021" className="card-img-top" height="250"  />
                <div className="card-body">
                <div className="text-start">
                    <p><strong>Departament: </strong>{departament}</p>
                    <p><strong>Municipality: </strong>{municipality}</p>
                    <p><strong>ZipCode: </strong>{zipCode}</p>
                    <p><strong>Neighborhood: </strong>{neighborhood}</p>
                </div>
                </div>
            </div>

        )
    }
}

export default Card;