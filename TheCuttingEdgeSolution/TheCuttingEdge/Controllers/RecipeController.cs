using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheCuttingEdge.Models;

namespace TheCuttingEdge.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeContext _context;

        public RecipeController(RecipeContext context)
        {
            _context = context;
        }

        // GET: Recipe
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recipes.ToListAsync());
        }

        // GET: Recipe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // GET: Recipe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recipe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RecipeId,RecipeTitle,RecipeDescription,RecipeUploadDate,RecipeUploader,Ingredient1,Ingredient2,Ingredient3,Ingredient4,Ingredient5,Ingredient6,Ingredient7,Ingredient8,Ingredient9,Ingredient10,Ingredient11,Ingredient12,Ingredient13,Ingredient14,Ingredient15,Ingredient16,Ingredient17,Ingredient18,Ingredient19,Ingredient20,StepNumber1,Step1Description,StepNumber2,Step2Description,StepNumber3,Step3Description,StepNumber4,Step4Description,StepNumber5,Step5Description,StepNumber6,Step6Description,StepNumber7,Step7Description,StepNumber8,Step8Description,StepNumber9,Step9Description,StepNumber10,Step10Description,StepNumber11,Step11Description,StepNumber12,Step12Description,StepNumber13,Step13Description,StepNumber14,Step14Description,StepNumber15,Step15Description,StepNumber16,Step16Description,StepNumber17,Step17Description,StepNumber18,Step18Description,StepNumber19,Step19Description,StepNumber20,Step20Description")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        // GET: Recipe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }

        // POST: Recipe/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RecipeId,RecipeTitle,RecipeDescription,RecipeUploadDate,RecipeUploader,Ingredient1,Ingredient2,Ingredient3,Ingredient4,Ingredient5,Ingredient6,Ingredient7,Ingredient8,Ingredient9,Ingredient10,Ingredient11,Ingredient12,Ingredient13,Ingredient14,Ingredient15,Ingredient16,Ingredient17,Ingredient18,Ingredient19,Ingredient20,StepNumber1,Step1Description,StepNumber2,Step2Description,StepNumber3,Step3Description,StepNumber4,Step4Description,StepNumber5,Step5Description,StepNumber6,Step6Description,StepNumber7,Step7Description,StepNumber8,Step8Description,StepNumber9,Step9Description,StepNumber10,Step10Description,StepNumber11,Step11Description,StepNumber12,Step12Description,StepNumber13,Step13Description,StepNumber14,Step14Description,StepNumber15,Step15Description,StepNumber16,Step16Description,StepNumber17,Step17Description,StepNumber18,Step18Description,StepNumber19,Step19Description,StepNumber20,Step20Description")] Recipe recipe)
        {
            if (id != recipe.RecipeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeExists(recipe.RecipeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        // GET: Recipe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // POST: Recipe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipeExists(int id)
        {
            return _context.Recipes.Any(e => e.RecipeId == id);
        }
    }
}
