using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEnvironmentDamageReceiverShape : ISerializable
	{
		private Transform _transform;

		[Ordinal(0)] 
		[RED("transform")] 
		public Transform Transform
		{
			get
			{
				if (_transform == null)
				{
					_transform = (Transform) CR2WTypeManager.Create("Transform", "transform", cr2w, this);
				}
				return _transform;
			}
			set
			{
				if (_transform == value)
				{
					return;
				}
				_transform = value;
				PropertySet(this);
			}
		}

		public gameEnvironmentDamageReceiverShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
