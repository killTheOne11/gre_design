<template>
    <div id="home">
       
<el-container id="el">
  <el-header id="head">
      <h1>基于区块链的数字版权保护系统</h1>
  </el-header>  
  <el-container id="aside">
    <el-aside width="200px">

<el-row class="tac">
      <el-col >
    <h5>您好 {{user}}</h5>
    <el-menu
      default-active="2"
      class="el-menu-vertical-demo"
      @open="handleOpen"
      @close="handleClose"
      background-color="#545c64"
      text-color="#fff"
      active-text-color="#ffd04b">
      <el-submenu index="1">
        <template slot="title">
          <i class="el-icon-location"></i>
          <span>信息查询</span>
        </template>


    <router-link to="/UserPage">
          <el-menu-item index="1-1">个人信息查询</el-menu-item>
                  </router-link> 


               <router-link to="/UserPageSearch">
           <el-menu-item index="1-2">个人业务查询</el-menu-item>
    </router-link>

      </el-submenu>

        <router-link to="/UserPageCreat">
          <el-menu-item index="2">业务办理</el-menu-item>
          </router-link>


       <router-link to="/UserPageRe">
          <el-menu-item index="4">意见反馈</el-menu-item>
          </router-link>

    <el-submenu index="3">
        <template slot="title">
          <i class="el-icon-location"></i>
          <span>设置</span>
        </template>

          <router-link to="/UserPageMo">
          <el-menu-item index="1-1">修改个人信息</el-menu-item>
          </router-link>


      </el-submenu>
      
    </el-menu>
  </el-col>
</el-row>


    </el-aside>
    <el-main>

        <h1>UserSend</h1>

    </el-main>
  </el-container>

    
</el-container>


    </div>


</template>

<script>
  export default {
    name:"UserPageSend",
    data() {
      return {
        options: [{
          value: '选项1',
          label: '管理员登录'
        }, {
          value: '选项2',
          label: '普通用户登录'
        }],
        value: '',
        input1: '',
        input2: '',
        user:"user",
        passwd: "passwd",
        email : "123@qq.com",
        previel: "普通用户"
      }
    }
  }
</script>

<style scoped>
#home{
    height: 100%;
    width: 100%;
}
#head{
    background-color: cornflowerblue;
    height: 400px;
}
#aside{
    height: 100%;
}
#el{
    height: 100%;
    background-image: url("https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fimg.mianfeiwendang.com%2Fpic%2F05920aaf71ff84271da705a3%2F1-810-jpg_6-1080-0-0-1080.jpg&refer=http%3A%2F%2Fimg.mianfeiwendang.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1652507976&t=574b8c86f9d8d935ca7776caba006084");
}

#image{
    height: 150px
}

#img{
    height: 100px;
    width: 100px;
}
</style>


