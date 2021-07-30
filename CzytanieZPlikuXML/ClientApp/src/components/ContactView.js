import React from 'react';


const ContactView = (props) => {

    return (
        
        <table>
            <thead>
                <tr>
                <th>
                    Imie
                </th>
                <th>
                    Nazwisko
                </th>
                <th>
                    Telefon
                </th>
                <th>
                    Email
                </th>
                </tr>
            </thead>
            <tbody>
                {
                    props.data.map((item, key) => {
                        return <tr key={key}><td>{item["Imie"]}</td><td>{item.Nazwisko}</td><td>{item.Telefon}</td><td>{item.Email}</td></tr>
                    })
                }
            </tbody>
        </table>
        );

}
export default ContactView;