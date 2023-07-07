using System.IdentityModel.Tokens.Jwt;
using TSClientSdk.TsApi;
using TSClientSdk.TsApi.Extensoes;
using TSClientSdk.TsApi.Modelos;
using TSClientSdk.TsApi.Rotas;

namespace TSControl
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private async void ValidaTokenExp_Tick(object sender, EventArgs e)
        {
            tsUsuario.Text = Properties.Settings.Default.User;
            tsExpiraToken.Text = "Sessão renova em " + (TSApiTools.Token.ExpirateDateToLocalTime() - DateTime.Now).ToString(@"hh\:mm\:ss");
            if (!TSApiTools.Token.IsConnected())
            {
                validaTokenExp.Enabled = false;
                UsuarioTokenResponse? usuarioResponse = await UsuarioRota.Token(Properties.Settings.Default.User, Properties.Settings.Default.Pass);
                if (!string.IsNullOrEmpty(usuarioResponse.Erro)) { MessageBox.Show(usuarioResponse.Erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit(); }
                else
                {
                    Properties.Settings.Default.Token = usuarioResponse.Token;
                    Properties.Settings.Default.Save();
                    TSApiTools.Token = new JwtSecurityToken(jwtEncodedString: Properties.Settings.Default.Token);
                    validaTokenExp.Enabled = true;
                }
            }
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void MeuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioResponse? retorno = await UsuarioRota.Visualizar(TSApiTools.Token.UserId());
                if (retorno == null) throw new Exception("Não foi possivel recuperar o usuario logado!");
                if (!string.IsNullOrEmpty(retorno.Erro)) throw new Exception(retorno.Erro);
                new FrmUsuarioVisualizar(retorno.Id, retorno.Apelido, retorno.Nome, retorno.Email, retorno.Admin.ToString()).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            tsUsuario.Text = TSApiTools.Token.UserName();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmZonasVisualizar().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
