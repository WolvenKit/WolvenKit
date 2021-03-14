using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMultiPrereq : gameIPrereq
	{
		private CEnum<gameAggregationType> _aggregationType;
		private CArray<CHandle<gameIPrereq>> _nestedPrereqs;

		[Ordinal(0)] 
		[RED("aggregationType")] 
		public CEnum<gameAggregationType> AggregationType
		{
			get
			{
				if (_aggregationType == null)
				{
					_aggregationType = (CEnum<gameAggregationType>) CR2WTypeManager.Create("gameAggregationType", "aggregationType", cr2w, this);
				}
				return _aggregationType;
			}
			set
			{
				if (_aggregationType == value)
				{
					return;
				}
				_aggregationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nestedPrereqs")] 
		public CArray<CHandle<gameIPrereq>> NestedPrereqs
		{
			get
			{
				if (_nestedPrereqs == null)
				{
					_nestedPrereqs = (CArray<CHandle<gameIPrereq>>) CR2WTypeManager.Create("array:handle:gameIPrereq", "nestedPrereqs", cr2w, this);
				}
				return _nestedPrereqs;
			}
			set
			{
				if (_nestedPrereqs == value)
				{
					return;
				}
				_nestedPrereqs = value;
				PropertySet(this);
			}
		}

		public gameMultiPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
