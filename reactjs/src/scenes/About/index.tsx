import * as React from 'react';

import { Col, Row } from 'antd';

export class About extends React.Component<any> {
  render() {
    return (
      <Row>
        <Col>
          <div>
            <div>
              <h2>About</h2>
            </div>
            <div>
            <p>
              This is a simple startup template based on ASP.NET Boilerplate
              framework and Module Zero. 
            </p>
            <h3>MIT License</h3>
            
            <p>            
              Copyright (c) 2016 ASP.NET Boilerplate
              <br /><br />
              Permission is hereby granted, free of charge, to any person obtaining a copy
              of this software and associated documentation files (the "Software"), to deal
              in the Software without restriction, including without limitation the rights
              to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
              copies of the Software, and to permit persons to whom the Software is
              furnished to do so, subject to the following conditions:
              <br /><br />
              The above copyright notice and this permission notice shall be included in all
              copies or substantial portions of the Software.

              <br /><br />
              THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
              IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
              FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
              AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
              LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
              OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
              SOFTWARE.
            </p>
            
            <h3>Source code</h3>
            <p>
              This template is developed open source on Github. You can contribute
              to the template.
              <a
                href="https://github.com/aspnetboilerplate/module-zero-core-template"
                target="_blank"
                >https://github.com/aspnetboilerplate/module-zero-core-template</a
              >
            </p>
            </div>
          </div>
        </Col>
      </Row>
    );
  }
}
export default About;
