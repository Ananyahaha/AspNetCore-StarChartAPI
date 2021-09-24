using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class CelestialObject
{
    public int Id;
    [Required]
    public string Name;
    public int OrbitedObjectId;
    public List<CelestialObject> Satellites;
    public TimeSpan OrbitalPeriod;



}
