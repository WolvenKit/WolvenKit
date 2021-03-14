using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOverridePhantomParamsEventParams : CVariable
	{
		private scnPerformerId _performer;
		private CName _overrideSpawnEffect;
		private CName _overrideIdleEffect;

		[Ordinal(0)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get
			{
				if (_performer == null)
				{
					_performer = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performer", cr2w, this);
				}
				return _performer;
			}
			set
			{
				if (_performer == value)
				{
					return;
				}
				_performer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("overrideSpawnEffect")] 
		public CName OverrideSpawnEffect
		{
			get
			{
				if (_overrideSpawnEffect == null)
				{
					_overrideSpawnEffect = (CName) CR2WTypeManager.Create("CName", "overrideSpawnEffect", cr2w, this);
				}
				return _overrideSpawnEffect;
			}
			set
			{
				if (_overrideSpawnEffect == value)
				{
					return;
				}
				_overrideSpawnEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("overrideIdleEffect")] 
		public CName OverrideIdleEffect
		{
			get
			{
				if (_overrideIdleEffect == null)
				{
					_overrideIdleEffect = (CName) CR2WTypeManager.Create("CName", "overrideIdleEffect", cr2w, this);
				}
				return _overrideIdleEffect;
			}
			set
			{
				if (_overrideIdleEffect == value)
				{
					return;
				}
				_overrideIdleEffect = value;
				PropertySet(this);
			}
		}

		public scnOverridePhantomParamsEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
