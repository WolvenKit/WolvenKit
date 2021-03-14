using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClueRecordData : CVariable
	{
		private TweakDBID _clueRecord;
		private CFloat _percentage;
		private CArray<SFactOperationData> _facts;
		private CBool _wasInspected;

		[Ordinal(0)] 
		[RED("clueRecord")] 
		public TweakDBID ClueRecord
		{
			get
			{
				if (_clueRecord == null)
				{
					_clueRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "clueRecord", cr2w, this);
				}
				return _clueRecord;
			}
			set
			{
				if (_clueRecord == value)
				{
					return;
				}
				_clueRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("percentage")] 
		public CFloat Percentage
		{
			get
			{
				if (_percentage == null)
				{
					_percentage = (CFloat) CR2WTypeManager.Create("Float", "percentage", cr2w, this);
				}
				return _percentage;
			}
			set
			{
				if (_percentage == value)
				{
					return;
				}
				_percentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get
			{
				if (_facts == null)
				{
					_facts = (CArray<SFactOperationData>) CR2WTypeManager.Create("array:SFactOperationData", "facts", cr2w, this);
				}
				return _facts;
			}
			set
			{
				if (_facts == value)
				{
					return;
				}
				_facts = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get
			{
				if (_wasInspected == null)
				{
					_wasInspected = (CBool) CR2WTypeManager.Create("Bool", "wasInspected", cr2w, this);
				}
				return _wasInspected;
			}
			set
			{
				if (_wasInspected == value)
				{
					return;
				}
				_wasInspected = value;
				PropertySet(this);
			}
		}

		public ClueRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
