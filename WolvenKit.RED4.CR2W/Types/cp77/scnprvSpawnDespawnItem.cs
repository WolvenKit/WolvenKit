using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnprvSpawnDespawnItem : CVariable
	{
		private TweakDBID _recordID;
		private Transform _finalTransform;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recordID", cr2w, this);
				}
				return _recordID;
			}
			set
			{
				if (_recordID == value)
				{
					return;
				}
				_recordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("finalTransform")] 
		public Transform FinalTransform
		{
			get
			{
				if (_finalTransform == null)
				{
					_finalTransform = (Transform) CR2WTypeManager.Create("Transform", "finalTransform", cr2w, this);
				}
				return _finalTransform;
			}
			set
			{
				if (_finalTransform == value)
				{
					return;
				}
				_finalTransform = value;
				PropertySet(this);
			}
		}

		public scnprvSpawnDespawnItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
