using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetDrivenKey : animAnimNode_Base
	{
		private animPoseLink _inputLink;
		private CHandle<animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider> _provider;

		[Ordinal(11)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get
			{
				if (_inputLink == null)
				{
					_inputLink = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "inputLink", cr2w, this);
				}
				return _inputLink;
			}
			set
			{
				if (_inputLink == value)
				{
					return;
				}
				_inputLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("provider")] 
		public CHandle<animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider> Provider
		{
			get
			{
				if (_provider == null)
				{
					_provider = (CHandle<animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider>) CR2WTypeManager.Create("handle:animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider", "provider", cr2w, this);
				}
				return _provider;
			}
			set
			{
				if (_provider == value)
				{
					return;
				}
				_provider = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SetDrivenKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
