using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentHiddenTrianglesRemovalParams : CVariable
	{
		private CFloat _garmentBorderThreshold;
		private CBool _removeHiddenTriangles;
		private CBool _removeHiddenTrianglesRasterization;
		private CFloat _rayLengthInCM;
		private CFloat _rayLengthMorphOffsetFactor;

		[Ordinal(0)] 
		[RED("garmentBorderThreshold")] 
		public CFloat GarmentBorderThreshold
		{
			get
			{
				if (_garmentBorderThreshold == null)
				{
					_garmentBorderThreshold = (CFloat) CR2WTypeManager.Create("Float", "garmentBorderThreshold", cr2w, this);
				}
				return _garmentBorderThreshold;
			}
			set
			{
				if (_garmentBorderThreshold == value)
				{
					return;
				}
				_garmentBorderThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("removeHiddenTriangles")] 
		public CBool RemoveHiddenTriangles
		{
			get
			{
				if (_removeHiddenTriangles == null)
				{
					_removeHiddenTriangles = (CBool) CR2WTypeManager.Create("Bool", "removeHiddenTriangles", cr2w, this);
				}
				return _removeHiddenTriangles;
			}
			set
			{
				if (_removeHiddenTriangles == value)
				{
					return;
				}
				_removeHiddenTriangles = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("removeHiddenTrianglesRasterization")] 
		public CBool RemoveHiddenTrianglesRasterization
		{
			get
			{
				if (_removeHiddenTrianglesRasterization == null)
				{
					_removeHiddenTrianglesRasterization = (CBool) CR2WTypeManager.Create("Bool", "removeHiddenTrianglesRasterization", cr2w, this);
				}
				return _removeHiddenTrianglesRasterization;
			}
			set
			{
				if (_removeHiddenTrianglesRasterization == value)
				{
					return;
				}
				_removeHiddenTrianglesRasterization = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rayLengthInCM")] 
		public CFloat RayLengthInCM
		{
			get
			{
				if (_rayLengthInCM == null)
				{
					_rayLengthInCM = (CFloat) CR2WTypeManager.Create("Float", "rayLengthInCM", cr2w, this);
				}
				return _rayLengthInCM;
			}
			set
			{
				if (_rayLengthInCM == value)
				{
					return;
				}
				_rayLengthInCM = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rayLengthMorphOffsetFactor")] 
		public CFloat RayLengthMorphOffsetFactor
		{
			get
			{
				if (_rayLengthMorphOffsetFactor == null)
				{
					_rayLengthMorphOffsetFactor = (CFloat) CR2WTypeManager.Create("Float", "rayLengthMorphOffsetFactor", cr2w, this);
				}
				return _rayLengthMorphOffsetFactor;
			}
			set
			{
				if (_rayLengthMorphOffsetFactor == value)
				{
					return;
				}
				_rayLengthMorphOffsetFactor = value;
				PropertySet(this);
			}
		}

		public garmentHiddenTrianglesRemovalParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
