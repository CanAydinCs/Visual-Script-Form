namespace Visual_Script_Forms
{
    public partial class FormFileSelector : Form
    {
        public FormFileSelector()
        {
            InitializeComponent();
        }

        private void FormFileSelector_Load(object sender, EventArgs e)
        {
            fileSelector.InitialDirectory = Application.StartupPath;
            fileSelector.Filter = "Visual Scripts Form files (*.vsf)|*.vsf";

            folderSelector.SelectedPath = Application.StartupPath;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if(folderSelector.ShowDialog() == DialogResult.OK)
            {
                string fileName = txtFile.Text == "" ? "New VSF Project" : txtFile.Text;

                string currentPath = folderSelector.SelectedPath + @"/" + fileName;
                string startFileName = currentPath + @"/" + fileName + ".vsf";

                Directory.CreateDirectory(currentPath);
                Directory.CreateDirectory(currentPath + @"/" + "workplaces");
                FileStream file = File.Create(startFileName);
                file.Close();

                OpenProject(startFileName);
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (!txtDir.Text.EndsWith(".vsf"))
            {
                MessageBox.Show("Please select a form!");
                return;
            }

            OpenProject(txtDir.Text);
        }

        private void BtnDir_Click(object sender, EventArgs e)
        {
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                txtDir.Text = fileSelector.FileName;
            }
        }

        private void OpenProject(string projectPath)
        {
            //TODO: fill this
            MessageBox.Show(projectPath + " has opened!");
        }
    }
}