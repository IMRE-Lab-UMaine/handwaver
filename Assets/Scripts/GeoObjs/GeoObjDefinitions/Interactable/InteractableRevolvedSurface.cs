/**
HandWaver, developed at the Maine IMRE Lab at the University of Maine's College of Education and Human Development
(C) University of Maine
See license info in readme.md.
www.imrelab.org
**/

﻿using Leap.Unity.Interaction;
using System;
using UnityEngine;

namespace IMRE.HandWaver
{
    /// <summary>
    /// An interactable revolved surface geometric object.
    /// Will be depreciated with new Geometery kernel
    /// </summary>
	class InteractableRevolvedSurface : AbstractRevolvedSurface, InteractiveFigure
    {
        internal override bool RMotion(NodeList<string> inputNodeList)
        {
            throw new NotImplementedException();
        }

        public void snapToCollider(Collider col)
        {
            throw new NotImplementedException();
        }

 public override void Stretch(InteractionController obj)
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