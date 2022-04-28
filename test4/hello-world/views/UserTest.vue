<template>
    <div>
        <el-button>默认按钮</el-button>
        <h1>111</h1>
    </div>
    
</template>

<script>
export default{
    name: 'UserTest',
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
    }
}
</script>
