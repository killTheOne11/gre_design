<template>
    <div id="register">
        <img src="../images/p21.jpeg" style="width: 30% ,height:20%">
            <h1>基于区块链的数字版权保护系统</h1>
            <h2>Userinfo</h2>






    </div>
</template>

<script>
export default{
    name: 'UserInfo',
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
#register{
  background-color: dodgerblue;
  width: 100%;
  height: 100%;
}
</style>
