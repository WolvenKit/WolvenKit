using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questParamKeepDistance : ISerializable
	{
		private CHandle<questUniversalRef> _companionTargetRef;
		private CFloat _distance;

		[Ordinal(0)] 
		[RED("companionTargetRef")] 
		public CHandle<questUniversalRef> CompanionTargetRef
		{
			get
			{
				if (_companionTargetRef == null)
				{
					_companionTargetRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "companionTargetRef", cr2w, this);
				}
				return _companionTargetRef;
			}
			set
			{
				if (_companionTargetRef == value)
				{
					return;
				}
				_companionTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		public questParamKeepDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
