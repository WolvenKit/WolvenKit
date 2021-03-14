using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScavengeComponent : gameScriptableComponent
	{
		private CArray<wCHandle<gameObject>> _scavengeTargets;

		[Ordinal(5)] 
		[RED("scavengeTargets")] 
		public CArray<wCHandle<gameObject>> ScavengeTargets
		{
			get
			{
				if (_scavengeTargets == null)
				{
					_scavengeTargets = (CArray<wCHandle<gameObject>>) CR2WTypeManager.Create("array:whandle:gameObject", "scavengeTargets", cr2w, this);
				}
				return _scavengeTargets;
			}
			set
			{
				if (_scavengeTargets == value)
				{
					return;
				}
				_scavengeTargets = value;
				PropertySet(this);
			}
		}

		public ScavengeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
