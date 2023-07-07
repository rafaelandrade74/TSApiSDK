

namespace TSControl
{
    public partial class FrmUsuarioVisualizar : Form
    {
        public FrmUsuarioVisualizar(string id, string apelido, string nome, string email, string admin)
        {
            InitializeComponent();
            txtIdUsuario.Text = id;
            txtApelido.Text= apelido;
            txtNome.Text= nome;
            txtEmail.Text= email;
            txtAdmin.Text= admin;
        }
    }
}
