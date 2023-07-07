using TSClientSdk.TsApi.Modelos;
using TSClientSdk.TsApi.Rotas;

namespace TSControl
{

    public partial class FrmZonasVisualizar : Form
    {

        const string frasePagina = "Pagina {0} de {1}";
        int paginaAtual = 0;
        int totalPaginas = 0;
        public FrmZonasVisualizar()
        {
            InitializeComponent();
            AtualizaPaginalbl(1, 1000);
        }
        private void AtualizaPaginalbl(int atual, int total)
        {
            lblPaginas.Text = string.Format(frasePagina, atual, total);
        }

        private async void BtnPageInicial_Click(object sender, EventArgs e)
        {
            await AtualizarGrid(1);
        }

        private async void BtnPageAnterior_Click(object sender, EventArgs e)
        {
            if(paginaAtual > 1) await AtualizarGrid(--paginaAtual);
        }

        private async void BtnProximo_Click(object sender, EventArgs e)
        {
            if (paginaAtual < totalPaginas) await AtualizarGrid(++paginaAtual);
        }

        private async void BtnPageFinal_Click(object sender, EventArgs e)
        {
            await AtualizarGrid(totalPaginas);
        }

        private async void FrmZonasVisualizar_Load(object sender, EventArgs e)
        {
            await AtualizarGrid(1);
        }
        private async Task AtualizarGrid(int pagina)
        {
            paginaAtual = pagina;
            ZonaPaginadoResponse? resposta = await ZonaRota.ObterPaginado(pagina, 50);
            totalPaginas = Convert.ToInt32(resposta.Parametros.First(x => x.Key.Equals("qtdePaginas")).Value);
            sfDataGrid1.DataSource = resposta.Dados;
            AtualizaPaginalbl(pagina, totalPaginas);
        }
    }
}
