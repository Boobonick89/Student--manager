using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Student__manager
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Student> _students = new BindingList<Student>();
        public event Action<Student>? StudentAdded;
        public event Action<Student>? StudentRemoved;
        public Form1()
        {
            InitializeComponent();
            lstStudents.DataSource = _students;

            StudentAdded += s => MessageBox.Show($"Студент {s.Name} {s.Age} лет добавлен");
            StudentRemoved += s => MessageBox.Show($"Студент {s.Name} {s.Age} лет удален");

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id) || id < 0)
            {
                MessageBox.Show("Введите число >0");
                return;

            }

            if (_students.Any(s => s.Id == id))
            {
                MessageBox.Show($"Студент с таким ID {id} уже существует ");
                return;
            }

            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 0)
            {
                MessageBox.Show("Введите корректный возраст");
                return;
            }

            var student = new Student(id, name, age);

            _students.Add(student);

            StudentAdded?.Invoke(student);

            txtID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtID.Focus();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem is not Student selected)
            {
                MessageBox.Show("Выберите студента для удаления");
                return;
            }

            _students.Remove(selected);

            StudentRemoved?.Invoke(selected);
        }

        private void BtnSearchName_Click(object sender, EventArgs e)
        {
            string query = txtSearchName.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Введите имя для поиска");
                return;
            }

            var result = _students.Where(s => s.Name.Equals(query, StringComparison.OrdinalIgnoreCase)).ToList();

            if (result.Count == 0)
            {
                MessageBox.Show($"Студента с именем {query} не найдено");
                return;
            }

            lstStudents.DataSource = null;
            lstStudents.DataSource = result;
        }

        private void BtnSearchAge_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSearchAge.Text, out int age) || age < 0)
            {
                MessageBox.Show("введите корректный возраст");
                return;
            }

            var result = _students.Where(s => s.Age == age).ToList();

            if (result.Count == 0)
            {
                MessageBox.Show($"Студент {age} лет не найдено");
                return;
            }

            lstStudents.DataSource = null;
            lstStudents.DataSource = result;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            lstStudents.DataSource = null;
            lstStudents.DataSource = _students;
        }
    }
}

