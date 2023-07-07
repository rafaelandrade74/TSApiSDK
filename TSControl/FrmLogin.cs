using System.IdentityModel.Tokens.Jwt;
using TSClientSdk.TsApi;
using TSClientSdk.TsApi.Extensoes;
using TSClientSdk.TsApi.Modelos;
using TSClientSdk.TsApi.Rotas;

namespace TSControl
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            txtUser.Text = Properties.Settings.Default.User != string.Empty ? Properties.Settings.Default.User : string.Empty;
            txtPass.Text = Properties.Settings.Default.Pass != string.Empty ? Properties.Settings.Default.Pass : string.Empty;
#if DEBUG
            TSApiTools.UrlBase = Properties.Settings.Default.UrlDev;
#else
            UrlsRotas.UrlBase = Properties.Settings.Default.UrlProd;
#endif
        }
        private void Liberar()
        {
            TSApiTools.Token = new JwtSecurityToken(jwtEncodedString: Properties.Settings.Default.Token);
            Hide();
            new FrmMenu().ShowDialog();
        }
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.Token))
                {
                    string tokenAtual = Properties.Settings.Default.Token;
                    TSApiTools.Token = new JwtSecurityToken(tokenAtual);
                }
                if (TSApiTools.Token == null || !TSApiTools.Token.IsConnected())
                {
                    UsuarioTokenResponse? usuarioResponse = await UsuarioRota.Token(txtUser.Text, txtPass.Text);
                    if (!string.IsNullOrEmpty(usuarioResponse.Erro)) throw new Exception(usuarioResponse.Erro);
                    else
                    {
                        Properties.Settings.Default.Token = usuarioResponse.Token;
                        Properties.Settings.Default.User = txtUser.Text;
                        Properties.Settings.Default.Pass = txtPass.Text;
                        Properties.Settings.Default.Save();
                        Liberar();
                    }
                }
                if (txtUser.Text.Equals(Properties.Settings.Default.User) && TSApiTools.Token != null && TSApiTools.Token.IsConnected())
                {
                    Liberar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}