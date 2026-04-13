using 訓練家管理系統.AllForms;
using 訓練家管理系統.MyControls.pokemonCard;
using 訓練家管理系統.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訓練家管理系統.MyControls
{
    public partial class ucPokemonInfo : UserControl
    {
        public ucPokemonInfo()
        {
            InitializeComponent();
        }

        private void ucPokemonInfo_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"{UserSession.currentUser.TrainerName}的寶可夢";
            LoadPokemonInfo(UserSession.currentUser.ID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PokemonDetail detail = new PokemonDetail(PokemonDetail.FormMode.ADD);
            detail.ShowDialog();

            LoadPokemonInfo(UserSession.currentUser.ID);
        }
        private void LoadPokemonInfo(int TrainerID)
        {
            tableLayoutPanelPokemon.Controls.Clear();

            tableLayoutPanelPokemon.Visible = false;
            btnAdd.Visible = true;

            PokemonRepositores pokemonRepositores = new PokemonRepositores();
            var pokemonList = pokemonRepositores.SearchPokemonInfo(TrainerID);

            if (pokemonList == null || pokemonList.Count == 0) return;

            int count = 0;
            foreach ( var p in pokemonList)
            {
                //ucCard1 card1 = new ucCard1();
                ucCard2 card2 = new ucCard2();

                //card1.SetData(p.PokemonName, p.Sex, p.Level, p.PokemonNo, count);
                card2.SetData(p.PokemonNo,p.PokemonName,p.nickname,p.Sex,p.Level);

                //card1.Anchor = AnchorStyles.None;
                card2.Anchor = AnchorStyles.None;

                int row = count / 3;
                int col = count % 3;
                tableLayoutPanelPokemon.Controls.Add(card2,col,row);
                count++;

                card2.Click += (s, args) =>
                {
                    PokemonDetail detail = new PokemonDetail(p.ID, PokemonDetail.FormMode.Edit);
                    detail.ShowDialog();

                    LoadPokemonInfo(TrainerID);
                };

            }
            if (count >= 6) btnAdd.Visible = false;
            tableLayoutPanelPokemon.Visible=true;
        }

    }
}
