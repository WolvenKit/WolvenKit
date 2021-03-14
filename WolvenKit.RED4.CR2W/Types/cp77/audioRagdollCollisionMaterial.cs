using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRagdollCollisionMaterial : audioAudioMetadata
	{
		private CName _lightCollisionEventName;
		private CName _heavyCollisionEventName;
		private CName _dismemberedLimbCollisionEventName;

		[Ordinal(1)] 
		[RED("lightCollisionEventName")] 
		public CName LightCollisionEventName
		{
			get
			{
				if (_lightCollisionEventName == null)
				{
					_lightCollisionEventName = (CName) CR2WTypeManager.Create("CName", "lightCollisionEventName", cr2w, this);
				}
				return _lightCollisionEventName;
			}
			set
			{
				if (_lightCollisionEventName == value)
				{
					return;
				}
				_lightCollisionEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("heavyCollisionEventName")] 
		public CName HeavyCollisionEventName
		{
			get
			{
				if (_heavyCollisionEventName == null)
				{
					_heavyCollisionEventName = (CName) CR2WTypeManager.Create("CName", "heavyCollisionEventName", cr2w, this);
				}
				return _heavyCollisionEventName;
			}
			set
			{
				if (_heavyCollisionEventName == value)
				{
					return;
				}
				_heavyCollisionEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dismemberedLimbCollisionEventName")] 
		public CName DismemberedLimbCollisionEventName
		{
			get
			{
				if (_dismemberedLimbCollisionEventName == null)
				{
					_dismemberedLimbCollisionEventName = (CName) CR2WTypeManager.Create("CName", "dismemberedLimbCollisionEventName", cr2w, this);
				}
				return _dismemberedLimbCollisionEventName;
			}
			set
			{
				if (_dismemberedLimbCollisionEventName == value)
				{
					return;
				}
				_dismemberedLimbCollisionEventName = value;
				PropertySet(this);
			}
		}

		public audioRagdollCollisionMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
