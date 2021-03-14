using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceMetaData : CVariable
	{
		private CString _tweakDBName;
		private TweakDBID _tweakDBID;
		private gameinteractionsChoiceTypeWrapper _type;

		[Ordinal(0)] 
		[RED("tweakDBName")] 
		public CString TweakDBName
		{
			get
			{
				if (_tweakDBName == null)
				{
					_tweakDBName = (CString) CR2WTypeManager.Create("String", "tweakDBName", cr2w, this);
				}
				return _tweakDBName;
			}
			set
			{
				if (_tweakDBName == value)
				{
					return;
				}
				_tweakDBName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tweakDBID")] 
		public TweakDBID TweakDBID
		{
			get
			{
				if (_tweakDBID == null)
				{
					_tweakDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "tweakDBID", cr2w, this);
				}
				return _tweakDBID;
			}
			set
			{
				if (_tweakDBID == value)
				{
					return;
				}
				_tweakDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get
			{
				if (_type == null)
				{
					_type = (gameinteractionsChoiceTypeWrapper) CR2WTypeManager.Create("gameinteractionsChoiceTypeWrapper", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public gameinteractionsChoiceMetaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
