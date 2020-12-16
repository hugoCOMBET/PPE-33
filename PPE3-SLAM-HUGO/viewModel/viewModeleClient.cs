﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;
using Model.Business;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;

namespace PPE3_SLAM_HUGO.viewModel 
{
    class viewModeleClient : viewModelBase
    {
        private DAOclients vmDaoClients;
        private DAOtransactions vmDaoTransaction;


        private Transactions selectedTransaction = new Transactions();
        private Clients selectedClient = new Clients();

        private ObservableCollection<Transactions> listTransactions;
        private ObservableCollection<Clients> listClient;

        public ObservableCollection<Clients> ListClient { get => listClient; set => listClient = value; }
        public ObservableCollection<Transactions> ListTransactions { get => listTransactions; set => listTransactions = value; }

        //private ICommand updateCommand;
        //private ICommand supprimerCommand;
        //private ICommand ajouterCommand;

        public viewModeleClient(DAOtransactions thedaoTransaction, DAOclients thedaoClient)
        {
            vmDaoClients = thedaoClient;
            vmDaoTransaction = thedaoTransaction;
            listClient = new ObservableCollection<Clients>(thedaoClient.SelectAll());
        }

        public Clients SelectedClient
        {
            get => selectedClient;
            set
            {
                if (selectedClient != value)
                {
                    selectedClient = value;
                    OnPropertyChanged("id");
                    OnPropertyChanged("nom");
                    OnPropertyChanged("prenom");
                    OnPropertyChanged("photo");
                    OnPropertyChanged("DateNaissance");
                    OnPropertyChanged("Email");
                    OnPropertyChanged("TelephonePortable");

                }
            }
        }
        public string Nom
        {
            get
            {
                if (selectedClient!= null)
                {
                    return selectedClient.getNomClient();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (selectedClient.getNomClient() != value)
                {
                    selectedClient.setNomClient(value);
                    //création d'un évènement si la propriété Name (bindée dans le XAML) change
                    OnPropertyChanged("Nom");
                }
            }
        }
        public string Prenom
        {
            get
            {
                if (selectedClient != null)
                {
                    return selectedClient.getPrenomClient();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (selectedClient.getPrenomClient() != value)
                {
                    selectedClient.setPrenomClient(value);
                    //création d'un évènement si la propriété Name (bindée dans le XAML) change
                    OnPropertyChanged("Prenom");
                }
            }
        }
        public DateTime DateNaissance
        {
            get
            {
                if (selectedClient != null)
                {
                    return selectedClient.getDateNaissanceClient();
                }
                else
                {
                    return new DateTime();
                }
            }
            set
            {
                if (selectedClient.getDateNaissanceClient() != value)
                {
                    selectedClient.setDateNaissanceClient(value);
                    //création d'un évènement si la propriété Name (bindée dans le XAML) change
                    OnPropertyChanged("DateNaissance");
                }
            }
        }
        public string Email
        {
            get
            {
                if (selectedClient != null)
                {
                    return selectedClient.getEmailClient();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (selectedClient.getEmailClient() != value)
                {
                    selectedClient.setEmailClient(value);
                    //création d'un évènement si la propriété Name (bindée dans le XAML) change
                    OnPropertyChanged("Email");
                }
            }
        }
        public string NumTel
        {
            get
            {
                if (selectedClient != null)
                {
                    return selectedClient.getTelPortableCLient();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (selectedClient.getTelPortableCLient() != value)
                {
                    selectedClient.setTelPortableCLient(value);
                    //création d'un évènement si la propriété Name (bindée dans le XAML) change
                    OnPropertyChanged("NumTel");
                }
            }
        }
        public string Adresse
        {
            get
            {
                if (selectedClient != null)
                {
                    return selectedClient.getAdresseClient();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (selectedClient.getAdresseClient() != value)
                {
                    selectedClient.setAdresseClient(value);
                    //création d'un évènement si la propriété Name (bindée dans le XAML) change
                    OnPropertyChanged("Adresse");
                }
            }
        }
        public double Credit
        {
            get
            {
                if (selectedClient != null)
                {
                    return selectedClient.getCreditClient();
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (selectedClient.getCreditClient() != value)
                {
                    selectedClient.setCreditClient(value);
                    //création d'un évènement si la propriété Name (bindée dans le XAML) change
                    OnPropertyChanged("Credit");
                }
            }
        }


        public Transactions SelectedTransaction
        {
            get => selectedTransaction;
            set
            {
                if (selectedTransaction != value)
                {
                    selectedTransaction = value;
                    OnPropertyChanged("id");
                    OnPropertyChanged("idClient");
                    OnPropertyChanged("MontantTransaction");
                }
            }
        }

        //private void UpdateCommand()
        //{
        //    Clients backup = new Clients();
        //    backup = SelectedClient;
        //    this.vmDaoClients.Update(this.SelectedClient);
        //    int a = listClient.IndexOf(SelectedClient);
        //    listClient.Insert(a, SelectedClient);
        //    listClient.RemoveAt(a + 1);
        //    SelectedClient = backup;
        //    MessageBox.Show("Mis à jour réussis");
        //}
        //public ICommand UpdateClient
        //{
        //    get
        //    {
        //        if (this.updateCommand == null)
        //        {
        //            this.updateCommand = new RelayCommand(() => UpdateCommand(), () => true);
        //        }
        //        return this.updateCommand;
        //    }
        //}


        
    }
}
