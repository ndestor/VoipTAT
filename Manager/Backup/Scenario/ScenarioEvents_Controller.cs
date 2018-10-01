using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using CommonProject.Tools;

namespace Manager.Scenario
{

    public delegate void _CloseScenarioResult(int _IndexTabPage, EventArgs e);

    /// <summary>
    /// Classe surveillant les process ex�cut� sur le Manager (cr�ation de sc�nario, lecture, etc...).
    /// </summary>

    public class ScenarioEvents
    {
        #region Manager EventHandler
        /// <summary>
        /// Handler g�rant l'�v�nement de cr�ation d'un sc�nario
        /// </summary>
        public event EventHandler NewScenario;
        /// <summary>
        /// Handler g�rant l'�v�nement de cr�ation d'un nouveau step
        /// </summary>
        public event EventHandler NewStep;
        /// <summary>
        /// Handler g�rant l'�v�nement de changement de status du sc�nario en cours de lecture 
        /// </summary>
        public event EventHandler PlayerStatus;
        /// <summary>
        /// Handler g�rant l'�v�nement d'�tat du manager (lecture d'un sc�nario ou au repos)
        /// </summary>
        public event EventHandler ManagerStatus;
        /// <summary>
        /// Handler g�rant l'�v�nement de cr�ation d'un r�sultat d'un sc�nario
        /// </summary>
        public event EventHandler NewScenarioResult;
        /// <summary>
        /// Handler g�rant l'�v�nement de s�lection d'un sc�nario par l'utilisateur (clic dans le treeview de gauche uniquement)
        /// </summary>
        public event EventHandler SelectScenarioEvent;
        /// <summary>
        /// Handler g�rant l'�v�nement de cr�ation d'une solution de sc�nario
        /// </summary>
        public event EventHandler NewScenarioSolution;
        /// <summary>
        /// Handler g�rant l'�v�nement de l'ajout d'un sc�nario � jouer
        /// </summary>
        public event EventHandler NewScenarioToPlay;
        /// <summary>
        /// Handler g�rant l'�v�nement d'arriv�e ou de cr�ation de nouvelles donn�es � enregistrer
        /// </summary>
        public event EventHandler NewRecordableDatas;
        /// <summary>
        /// Handler g�rant l'�v�nement de l'arriv� d'une fiche r�sultat d'un sc�nario � afficher
        /// </summary>
        public event EventHandler NewScenarioResultToView;
        /// <summary>
        /// Handler g�rant l'�v�nement de la fermeture d'une fiche r�sultat
        /// </summary>
        public event _CloseScenarioResult CloseScenarioResult;

        #endregion 

        /* Pour tous les �v�nements ci dessous, l'objet sender est instanci� avec l'objet 
         * � l'origine de l'�v�nement.
         * Exemple : Pour l'�v�nement "NewScenario", le sender correspond � l'objet scenario 
         * venant d'�tre cr��.
         */

        public virtual void OnNewRecordableDatas(object sender, EventArgs e)
        {
            if (NewRecordableDatas != null)
            {
                NewRecordableDatas(sender, e);
            }
        }

        public virtual void OnNewScenarioToPlay(object sender, EventArgs e)
        {
            if (NewScenarioToPlay != null)
            {
                NewScenarioToPlay(sender, e);
            }
        }

        public virtual void OnNewScenario(object sender, EventArgs e)
        {
            if (NewScenario != null)
            {
                NewScenario(sender, e);
            }
        }

        public virtual void OnNewStep(object sender, EventArgs e)
        {
            if (NewStep != null)
            {
                NewStep(sender, e);
            }
        }

        public virtual void OnNewScenarioSolution(object sender, EventArgs e)
        {
            if (NewScenarioSolution != null)
            {
                NewScenarioSolution(sender, e);
            }
        }

        public void OnSelectScenarioEvent(object sender, EventArgs e)
        {
            if (SelectScenarioEvent != null)
            {
                SelectScenarioEvent(sender, e);
            }
        }

        public void OnPlayerStatusChange(object sender, EventArgs e)
        {
            if (PlayerStatus != null)
            {
                PlayerStatus(sender, e);
            }
        }

        public void OnNewScenarioResult(object sender, EventArgs e)
        {
            if (NewScenarioResult != null)
            {
                NewScenarioResult(sender, e);
            }
        }             

        public virtual void OnManagerStatusChange(object sender, EventArgs e)
        {
            if (ManagerStatus != null)
            {
                ManagerStatus(sender, e);
            }
        }

        public virtual void OnNewScenarioResultToView(object sender, EventArgs e)
        {
            if (NewScenarioResultToView != null)
            {
                NewScenarioResultToView(sender, e);
            }
        }

        public virtual void OnCloseScenarioResult(int _IndexTabPage, EventArgs e)
        {
            if (CloseScenarioResult != null)
            {
                CloseScenarioResult(_IndexTabPage, e);
            }
        }
    }
}
