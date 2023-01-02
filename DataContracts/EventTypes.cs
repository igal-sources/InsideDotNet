using System.Collections.ObjectModel;

namespace InsideDotNet.DataContracts
{
    public class EventTypes
    {
        #region Primitive Properties

        private int _eventTypeId;
        public int EventTypeId
        {
            get { return _eventTypeId; }
            set { if (_eventTypeId == value) return; _eventTypeId = value; }
        }

        public string EventTypeName
        {
            get { return _eventTypeName; }
            set { if (_eventTypeName == value) return; _eventTypeName = value; }
        }

        private string _eventTypeName;

        public int ParentId
        {
            get { return _parentId; }
            set { if (_parentId == value) return; _parentId = value; }
        }

        private int _parentId;

        public int TermId
        {
            get { return _termId; }
            set { if (_termId == value) return; _termId = value; }
        }

        private int _termId;

        public byte[] Icon
        {
            get { return _icon; }
            set { if (_icon == value) return; _icon = value; }
        }

        private byte[] _icon;

        public System.DateTime DateCreated
        {
            get { return _dateCreated; }
            set { if (_dateCreated == value) return; _dateCreated = value; }
        }

        private System.DateTime _dateCreated;

        public System.DateTime DateModified
        {
            get { return _dateModified; }
            set { if (_dateModified == value) return; _dateModified = value; }
        }

        private System.DateTime _dateModified;

        public string Description
        {
            get { return _description; }
            set { if (_description == value) return; _description = value; }
        }

        private string _description;

        public string AdditionalValues
        {
            get { return _additionalValues; }
            set { if (_additionalValues == value) return; _additionalValues = value; }
        }

        private string _additionalValues;

        public string ChangedBy
        {
            get { return _changedBy; }
            set { if (_changedBy == value) return; _changedBy = value; }
        }

        private string _changedBy;

        public System.Guid CITguid
        {
            get { return _cITguid; }
            set { if (_cITguid == value) return; _cITguid = value; }
        }

        private System.Guid _cITguid;

        public int ConfigVersion
        {
            get { return _configVersion; }
            set { if (_configVersion == value) return; _configVersion = value; }
        }

        private int _configVersion;

        public ObservableCollection<EventTypes> Children { get; set; }

        #endregion

    }
}
