<template>
    <div id="home">
        <img src="../images/p1.jpeg">
            <h1>基于区块链的数字版权保护系统</h1>
            <h2>登录界面</h2>
            
        <el-select v-model="value" placeholder="请选择登录用户权限" style="width: 24%">
            <el-option
            v-for="item in options"
            :key="item.value"
            :label="item.label"
            :value="item.value">
            </el-option>
        </el-select>
<br>
<el-input v-model="input1" placeholder="请输入用户名"  style="width: 24%"></el-input>
<br>
<el-input v-model="input2" placeholder="请输入密码" style="width: 24%"></el-input>

        <el-row>
            <el-button type="success" style="width: 8%" size="mini">登录</el-button>
                  <router-link to="/RegisterView">
            <el-button type="primary" style="width: 8%" size="mini">注册</el-button>
        </router-link> 
         <router-link to="/ForgetView">
            <el-button @click="obsubmit" type="info" style="width: 8%" size="mini">忘记密码</el-button>
        </router-link> 
        </el-row>


    </div>


</template>

<script>
import axios from 'axios'

  export default {
    name:"HomeTest",
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
        input2: ''
      }
    },
    methods : {
      obsubmit:function(){
        axios.get("/testadmin")
        .then(function (res){
          console.log(res);
        })
      }
    }
    
  }
</script>

<style scoped>
/* #home{
            background: url("https://img0.baidu.com/it/u=3100416073,2821167444&fm=253&fmt=auto&app=138&f=JPEG?w=646&h=408") no-repeat center center fixed;
                -webkit-background-size: cover;
                -o-background-size: cover;                
                background-size: cover;
    
} */

#home{
    background-color: dodgerblue;
    height: 100%;
    width: 100%;
}

</style>


