using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameObjectCarrierComponent : entIComponent
	{
		private TweakDBID _objectToSpawn;

		[Ordinal(3)] 
		[RED("objectToSpawn")] 
		public TweakDBID ObjectToSpawn
		{
			get
			{
				if (_objectToSpawn == null)
				{
					_objectToSpawn = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "objectToSpawn", cr2w, this);
				}
				return _objectToSpawn;
			}
			set
			{
				if (_objectToSpawn == value)
				{
					return;
				}
				_objectToSpawn = value;
				PropertySet(this);
			}
		}

		public gameObjectCarrierComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
