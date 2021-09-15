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

  post() {
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

}
