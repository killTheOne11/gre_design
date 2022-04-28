import Vue from "vue"
import VueRouter from "vue-router"


Vue.use(VueRouter)

const routes = [
    {
        path:'/',
        name:'HomeTest',
        component: () => import('../views/HomeTest.vue')
    },
    {
        path:'/UserTest',
        name:'UserTest',
        component: () => import('../views/UserTest.vue')
    },
    {
        path:'/RegisterView',
        name:'Register',
        component: () => import('../views/RegisterView.vue')
    },
    {
        path:'/ForgetView',
        name:'ForgetView',
        component: () => import('../views/ForgetView.vue')
    },
    {
        path:'/UserPage',
        name:'UserPage',
        component: () => import('../views/UserPage.vue')
    },
    {
        path:'/UserInfo',
        name:'UserInfo',
        component: () => import('../views/UserInfo.vue')
    },
    {
        path:'/UserPageMo',
        name:'UserPageMo',
        component: () => import('../views/UserPageMo.vue')
    },
    {
        path:'/UserPageSearch',
        name:'UserPageSearch',
        component: () => import('../views/UserPageSearch.vue')
    },
    {
        path:'/UserPageSend',
        name:'UserPageSend',
        component: () => import('../views/UserPageSend.vue')
    },
    {
        path:'/UserPageCreat',
        name:'UserPageCreat',
        component: () => import('../views/UserPageCreat.vue')
    },
    {
        path:'/UserPageRe',
        name:'UserPageRe',
        component: () => import('../views/UserPageRe.vue')
    },
    {
        path:'/AdminPage',
        name:'AdminPage',
        component: () => import('../views/AdminPage.vue')
    },
    {
        path:'/AdminPageMo',
        name:'AdminPageMo',
        component: () => import('../views/AdminPageMo.vue')
    },
    {
        path:'/AdminPageUser',
        name:'AdminPageUser',
        component: () => import('../views/AdminPageUser.vue')
    },
    {
        path:'/AdminPageRe',
        name:'AdminPageRe',
        component: () => import('../views/AdminPageRe.vue')
    },
    {
        path:'/AdminPagePass',
        name:'AdminPagePass',
        component: () => import('../views/AdminPagePass.vue')
    },
    {
        path:'/AdminPageNotPass',
        name:'AdminPageNotPass',
        component: () => import('../views/AdminPageNotPass.vue')
    },
    {
        path:'/AdminPageHandle',
        name:'AdminPageHandle',
        component: () => import('../views/AdminPageHandle.vue')
    },
]


const router = new VueRouter({
    mode: 'history',
    routes
})

export default router