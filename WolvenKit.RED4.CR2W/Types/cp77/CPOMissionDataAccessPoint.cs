using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDataAccessPoint : CPOMissionDevice
	{
		private CBool _hasDataToDownload;
		private CName _damagesPresetName;
		private CArray<SFactToChange> _factsOnDownload;
		private CArray<SFactToChange> _factsOnUpload;
		private CBool _ownerDecidesOnTransfer;

		[Ordinal(45)] 
		[RED("hasDataToDownload")] 
		public CBool HasDataToDownload
		{
			get
			{
				if (_hasDataToDownload == null)
				{
					_hasDataToDownload = (CBool) CR2WTypeManager.Create("Bool", "hasDataToDownload", cr2w, this);
				}
				return _hasDataToDownload;
			}
			set
			{
				if (_hasDataToDownload == value)
				{
					return;
				}
				_hasDataToDownload = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("damagesPresetName")] 
		public CName DamagesPresetName
		{
			get
			{
				if (_damagesPresetName == null)
				{
					_damagesPresetName = (CName) CR2WTypeManager.Create("CName", "damagesPresetName", cr2w, this);
				}
				return _damagesPresetName;
			}
			set
			{
				if (_damagesPresetName == value)
				{
					return;
				}
				_damagesPresetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("factsOnDownload")] 
		public CArray<SFactToChange> FactsOnDownload
		{
			get
			{
				if (_factsOnDownload == null)
				{
					_factsOnDownload = (CArray<SFactToChange>) CR2WTypeManager.Create("array:SFactToChange", "factsOnDownload", cr2w, this);
				}
				return _factsOnDownload;
			}
			set
			{
				if (_factsOnDownload == value)
				{
					return;
				}
				_factsOnDownload = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("factsOnUpload")] 
		public CArray<SFactToChange> FactsOnUpload
		{
			get
			{
				if (_factsOnUpload == null)
				{
					_factsOnUpload = (CArray<SFactToChange>) CR2WTypeManager.Create("array:SFactToChange", "factsOnUpload", cr2w, this);
				}
				return _factsOnUpload;
			}
			set
			{
				if (_factsOnUpload == value)
				{
					return;
				}
				_factsOnUpload = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("ownerDecidesOnTransfer")] 
		public CBool OwnerDecidesOnTransfer
		{
			get
			{
				if (_ownerDecidesOnTransfer == null)
				{
					_ownerDecidesOnTransfer = (CBool) CR2WTypeManager.Create("Bool", "ownerDecidesOnTransfer", cr2w, this);
				}
				return _ownerDecidesOnTransfer;
			}
			set
			{
				if (_ownerDecidesOnTransfer == value)
				{
					return;
				}
				_ownerDecidesOnTransfer = value;
				PropertySet(this);
			}
		}

		public CPOMissionDataAccessPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
