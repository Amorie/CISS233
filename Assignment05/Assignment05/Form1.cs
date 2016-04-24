using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment05
{
    public partial class Form1 : Form
    {
        private decimal _input;
        private decimal? _value;
        private Opperands? _lastOpperator;
        private bool _noError;

        private enum Opperands
        {
            Add,
            Subtract,
            Multiply,
            Divide
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _input = 0;
            _value = null;
            _lastOpperator = null;
            _noError = true;
            tbInput.Focus();
        }

        private void ClearAll()
        {
            _input = 0;
            _value = null;
            _lastOpperator = null;
            tbInput.Clear();
            tbInput.ForeColor = DefaultForeColor;
            _noError = true;
        }

        private void ClearRecent()
        {
            _input = 0;
            _lastOpperator = null;
        }

        //All button events ecept clear have two checks for errors.
        //outer check to prevent functionality while there is an error
        // inner check because error dection happens during applying of last opperand.
        //so if there is an error we want to stop further funtionality. 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_noError)
            {
                ApplyLastOpperand();
                if (_noError)
                {
                    _lastOpperator = Opperands.Add;
                    tbInput.Clear();
                    tbInput.Focus();
                }
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (_noError)
            {
                ApplyLastOpperand();
                if (_noError)
                {
                    _lastOpperator = Opperands.Subtract;
                    tbInput.Clear();
                    tbInput.Focus();
                }
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (_noError)
            {
                ApplyLastOpperand();
                if (_noError)
                {
                    _lastOpperator = Opperands.Multiply;
                    tbInput.Clear();
                    tbInput.Focus();
                }
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (_noError)
            {
                ApplyLastOpperand();
                if (_noError)
                {
                    _lastOpperator = Opperands.Divide;
                    tbInput.Clear();
                    tbInput.Focus();
                }
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (_noError)
            {
                ApplyLastOpperand();
                if (_noError)
                {
                    tbInput.Text = _value.ToString();
                    ClearRecent();
                    tbInput.Focus();
                }
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            tbInput.Focus();
        }

        //
        private bool IsValidInput()
        {
            decimal result;

            if (decimal.TryParse(tbInput.Text, out result))
            {
                _input = result;
                return true;
            }

            tbInput.Text = "Invalid Input Click Clear(C)";
            tbInput.ForeColor = Color.Red;
            _noError = false;
            return false;
        }


        private void ApplyLastOpperand()
        {
            if (IsValidInput())
            {
                switch (_lastOpperator)
                {
                    case Opperands.Add:
                        _value += _input;
                        break;
                    case Opperands.Subtract:
                        _value -= _input;
                        break;
                    case Opperands.Multiply:
                        _value *= _input;
                        break;
                    case Opperands.Divide:
                        if (_input == 0)
                        {
                            tbInput.Text = "Cannot Divide by 0, Click Clear(C)";
                            tbInput.ForeColor = Color.Red;
                            _noError = false;
                            return;
                        }
                        _value /= _input;
                        break;
                    default:
                        _value = _input;
                        break;
                }
            }
        }

        
    }
}
