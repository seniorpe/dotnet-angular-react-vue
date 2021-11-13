import * as React from 'react';
import { Layout } from 'antd';
import './index.less';
const Footer = () => {
  
  return (
    <Layout.Footer className={'footer'} style={{ textAlign: 'center' }}>
      React © 2021 <a href="https://github.com/seniorpe/dotnet-angular-react-vue">Github Page</a>
    </Layout.Footer>
  );
};
export default Footer;
