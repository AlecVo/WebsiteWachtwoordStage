const app = Vue.createApp(
    {
      data() {
        return {
          showNav: false
        }
      },
      methods: {
        burgerToggle(){
         this.showNav = !this.showNav
        }
      }
    }
)

app.mount('#navbar')