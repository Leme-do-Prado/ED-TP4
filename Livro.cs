public class Livro{
    int isbn;
    string titulo;
    string autor;
    string editora;
    List<Exemplar> exemplares;

    public Livro(int i, string t, string a, string e){
        this.isbn = i;
        this.titulo = t;
        this.autor = a;
        this.editora = e;
    }

    public void adicionarExemplar(Exemplar exemplar){
        exemplares.Add(exemplar);
    }

    public int qtdeExemplares(){
        int i = 0;
        foreach(Exemplar in exemplares){
            i++;
        }
return i;
    }

    public int qtdeDisponiveis(){
        int i = 0;
        foreach(Exemplar in exemplares){
            if(disponivel == true){
                i++
            }
        }
        return i;
    }

    public int qtdeEmprestimos(){
        int i = 0;
        foreach(Exemplar in exemplares){
            if(emprestar == true){
                i++
            }
        }
        return i;
    }

    public double percDisponibilidade(){
        int i = qtdeDisponiveis;
        int j = qtdeExemplares;
        double perc;

        perc = i/j * 100;

        return perc;
    }

}

public class Exemplar{
    int tombo;
    List<Emprestimo> emprestimos;

    public bool emprestar(){
        emprestado == true;
        dispo
    }
}

