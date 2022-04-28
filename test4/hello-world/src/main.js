import Vue from 'vue'
import App from './App.vue'
import ElementUI from 'element-ui';
import 'element-ui/lib/theme-chalk/index.css';
import router from '../router'
import axios from 'axios'


Vue.config.productionTip = false

axios.defaults.baseURL = "http://127.0.0.1:7998/"


Vue.use(ElementUI)
new Vue({
  router,
  render: h => h(App),
}).$mount('#app')
Vue.tmpuser = "admin"
