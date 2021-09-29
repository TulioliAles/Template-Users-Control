import { Component, OnInit } from '@angular/core';
import { UserDataService } from '../_data-services/user.data-service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  users: any[] = [];
  user: any = {};
  showList: boolean = true;

  constructor(private userDataService: UserDataService) { }

  ngOnInit() {
    this.get();
  }

  get() {
    this.userDataService.get().subscribe((data: any[]) => {
      this.users = data;
      this.showList = true;
    }, error => {
      console.log(error);
      alert('Erro interno da Sistema.');
    });
  }

  save() {
    if(this.user.id)
      this.put
    else
      this.post
  }

  openDetails(user){
    this.showList = false;
    this.user = user;
  }

  post(){
    this.userDataService.post(this.user).subscribe( data => {
      if(data) {
        alert('Usuário Cadastrado com Sucesso!');
        this.get();
        this.user = '';
      } else {
        alert('Erro ao Cadastrar Usuário!');
      }
    }, error => {
      console.log(error);
      alert('Erro interno da Sistema.');
    });
  }

  put(){
    this.userDataService.put(this.user).subscribe( data => {
      if(data) {
        alert('Usuário Atualizado com Sucesso!');
        this.get();
        this.user = '';
      } else {
        alert('Erro ao Atualizar Usuário!');
      }
    }, error => {
      console.log(error);
      alert('Erro interno da Sistema.');
    });
  }

  delete(){
    this.userDataService.delete(this.user.id).subscribe( data => {
      if(data) {
        alert('Usuário Excluido com Sucesso!');
        this.get();
        this.user = {};
      } else {
        alert('Erro ao Excluir Usuário!');
      }
    }, error => {
      console.log(error);
      alert('Erro interno da Sistema.');
    });
  }

}
