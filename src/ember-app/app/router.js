import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-prilozhenie-город-l');
  this.route('i-i-s-prilozhenie-город-e',
  { path: 'i-i-s-prilozhenie-город-e/:id' });
  this.route('i-i-s-prilozhenie-город-e.new',
  { path: 'i-i-s-prilozhenie-город-e/new' });
  this.route('i-i-s-prilozhenie-здание-l');
  this.route('i-i-s-prilozhenie-здание-e',
  { path: 'i-i-s-prilozhenie-здание-e/:id' });
  this.route('i-i-s-prilozhenie-здание-e.new',
  { path: 'i-i-s-prilozhenie-здание-e/new' });
});

export default Router;
