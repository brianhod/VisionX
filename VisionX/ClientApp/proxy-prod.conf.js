const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:29930';

const PROXY_CONFIG = [
  {
    context: [
      "/GetOrderBook",
   ],
    target: "http://surenext.co.za",
    secure: false
  }
]

module.exports = PROXY_CONFIG;

