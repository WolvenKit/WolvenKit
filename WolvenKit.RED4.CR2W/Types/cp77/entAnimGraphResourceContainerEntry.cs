using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimGraphResourceContainerEntry : CVariable
	{
		private CName _graphName;
		private rRef<animAnimGraph> _animGraphResource;

		[Ordinal(0)] 
		[RED("graphName")] 
		public CName GraphName
		{
			get
			{
				if (_graphName == null)
				{
					_graphName = (CName) CR2WTypeManager.Create("CName", "graphName", cr2w, this);
				}
				return _graphName;
			}
			set
			{
				if (_graphName == value)
				{
					return;
				}
				_graphName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animGraphResource")] 
		public rRef<animAnimGraph> AnimGraphResource
		{
			get
			{
				if (_animGraphResource == null)
				{
					_animGraphResource = (rRef<animAnimGraph>) CR2WTypeManager.Create("rRef:animAnimGraph", "animGraphResource", cr2w, this);
				}
				return _animGraphResource;
			}
			set
			{
				if (_animGraphResource == value)
				{
					return;
				}
				_animGraphResource = value;
				PropertySet(this);
			}
		}

		public entAnimGraphResourceContainerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
