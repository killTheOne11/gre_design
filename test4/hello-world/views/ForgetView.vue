<template>
    <div id="forget">
        <img src="../images/p31.jpeg" style="width: 30% ,height:20%">
            <h1>基于区块链的数字版权保护系统</h1>
            <h2>找回密码界面</h2>

<br>
<el-input v-model="input1" placeholder="请输入要找回密码邮箱号"  style="width: 24%"></el-input>



        <el-row>
            <el-button type="success" style="width: 8%" size="mini">确认提交</el-button>
            <router-link to="/">
            &ensp;&ensp;&ensp;
            <el-button type="info" style="width: 8%" size="mini">点击返回登陆界面</el-button>
        </router-link> 
        </el-row>


    </div>
</template>

<script>
export default{
    name: 'ForgetView',
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
        input3:'',
        input4:''
      }
    }
}
</script>

<style scoped>
#forget{
  background-color: dodgerblue;
  width: 100%;
  height: 100%;
}
</style>