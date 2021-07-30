import React, { Component } from 'react';
import ContactView from './components/ContactView';
import $ from 'jquery';


export default class App extends Component {
    constructor(props) {
        super(props);
        this.state = {
            data: [],
            rendering: true
        };

    }
    componentDidMount() {
        this.GetData();
    }
    render() {
        return (
            <div>
                {
                    this.state.rendering === false ?
                        <ContactView data={this.state.data}/>
                        :
                        <span>brak danych</span>
                }

            </div>
        );
    }

    async GetData() {
        $.get("https://localhost:44361/Home/GetContacts",
            (data) => { })
            .done((data) => {
                var list = this.state.data;
                data.map(item => list.push(JSON.parse(item)));
                this.setState({ data: list, rendering: false }
                    )
            });
    }
}