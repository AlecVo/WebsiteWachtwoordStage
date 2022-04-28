const app = Vue.createApp(
  {
    data() {
      return {
        showNav: false,
        wachtwoord: false
      }
    },
    methods: {
      burgerToggle(){
       this.showNav = !this.showNav
      },
      wachtwoordToggle(){
        this.wachtwoord = !this.wachtwoord
      }
    }
  }
)

app.mount('#container')
                        
                        