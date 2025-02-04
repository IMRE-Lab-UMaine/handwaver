/**
HandWaver, developed at the Maine IMRE Lab at the University of Maine's College of Education and Human Development
(C) University of Maine
See license info in readme.md.
www.imrelab.org
**/

using Leap.Unity.Interaction;
using System;
using System.Collections.Generic;

namespace IMRE.HandWaver
{
/// <summary>
/// Definition for solid figures that don't change.
/// </summary>
	class StaticSolid : AbstractSolid, StaticFigure
    {
        internal override float volume
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        internal override AbstractPolygon primaryBase { get { throw new NotImplementedException(); } }

		internal override List<AbstractPolygon> allfaces
		{
			get
			{
				throw new NotImplementedException();
			}
		}

        internal override bool RMotion(NodeList<string> inputNodeList)
        {
            throw new NotImplementedException();
        }

 public override void Stretch(InteractionController obj)
		{
			throw new NotImplementedException();
		}

		public override void updateFigure()
        {
            throw new NotImplementedException();
        }

        internal override void GlueToFigure(AbstractGeoObj toObj)
        {
            throw new NotImplementedException();
        }

        internal override void SnapToFigure(AbstractGeoObj toObj)
		{
			//do nothing
		}
	}
}